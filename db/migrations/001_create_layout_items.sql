-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, token, rank, region) VALUES (81.55, 'latest', 86, 'legacy');
INSERT INTO layout_items (ratio, token, rank, region) VALUES (70.38, 'primary', 99, 'cached');
