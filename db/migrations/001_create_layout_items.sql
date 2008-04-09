-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, ratio, level) VALUES (99, 65.48, 81);
INSERT INTO layout_items (rank, ratio, level) VALUES (12, 80.19, 60);
INSERT INTO layout_items (rank, ratio, level) VALUES (67, 94.66, 16);
