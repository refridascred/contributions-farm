-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, level, rank) VALUES (23, 45, 41);
INSERT INTO layout_items (count, level, rank) VALUES (80, 39, 70);
INSERT INTO layout_items (count, level, rank) VALUES (65, 97, 34);
