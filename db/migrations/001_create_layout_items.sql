-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, active, token) VALUES (93.65, 'eu-west', 44, 'staging');
INSERT INTO layout_items (ratio, region, active, token) VALUES (26.76, 'staging', 51, 'stable');
INSERT INTO layout_items (ratio, region, active, token) VALUES (85.06, 'open', 34, 'blue');
