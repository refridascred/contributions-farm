-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, token, region) VALUES ('standard', 61.29, 'primary', 'fallback');
INSERT INTO layout_items (owner, ratio, token, region) VALUES ('local', 55.82, 'fallback', 'legacy');
INSERT INTO layout_items (owner, ratio, token, region) VALUES ('staging', 5.88, 'strict', 'eu-west');
