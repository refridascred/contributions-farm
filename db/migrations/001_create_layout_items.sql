-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, count, rank) VALUES (77, 25, 69);
INSERT INTO layout_items (level, count, rank) VALUES (99, 22, 47);
INSERT INTO layout_items (level, count, rank) VALUES (1, 58, 18);
