-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, level, ratio, count) VALUES ('blue', 'standard', 3, 33.41, 57);
INSERT INTO layout_items (region, token, level, ratio, count) VALUES ('staging', 'legacy', 73, 14.23, 36);
