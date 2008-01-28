-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, ratio, weight) VALUES (59, 67, 72.4, 4.23);
INSERT INTO layout_items (level, rank, ratio, weight) VALUES (6, 42, 38.52, 75.83);
INSERT INTO layout_items (level, rank, ratio, weight) VALUES (12, 79, 79.21, 61.05);
