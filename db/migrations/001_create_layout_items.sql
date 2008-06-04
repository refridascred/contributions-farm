-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, rank, level, region) VALUES (37.76, 69, 72, 'latest');
INSERT INTO layout_items (weight, rank, level, region) VALUES (45.84, 39, 1, 'staging');
