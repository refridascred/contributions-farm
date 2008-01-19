-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, level, weight, ratio) VALUES (23, 95, 35.01, 66.28);
INSERT INTO layout_items (rank, level, weight, ratio) VALUES (1, 76, 43.55, 53.89);
INSERT INTO layout_items (rank, level, weight, ratio) VALUES (8, 86, 40.91, 63.54);
