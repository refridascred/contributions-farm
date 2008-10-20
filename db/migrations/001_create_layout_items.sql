-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, level, weight, region) VALUES (96, 50, 75.13, 'edge');
INSERT INTO layout_items (rank, level, weight, region) VALUES (17, 11, 52.24, 'staging');
INSERT INTO layout_items (rank, level, weight, region) VALUES (31, 28, 53.53, 'open');
