-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, token, region, owner, label) VALUES (7.57, 'blue', 'fallback', 'staging', 'strict');
INSERT INTO layout_items (ratio, token, region, owner, label) VALUES (75.5, 'standard', 'legacy', 'fallback', 'strict');
