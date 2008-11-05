-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, level, rank, region) VALUES (24.43, 93, 40, 'local');
INSERT INTO layout_items (ratio, level, rank, region) VALUES (82.33, 79, 67, 'standard');
