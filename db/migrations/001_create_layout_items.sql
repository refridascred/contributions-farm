-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, token) VALUES ('local', 13.42, 'cached');
INSERT INTO layout_items (region, ratio, token) VALUES ('stable', 35.94, 'cached');
