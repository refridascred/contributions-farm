-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, label, weight, count) VALUES (95, 'local', 25.87, 21);
INSERT INTO layout_items (rank, label, weight, count) VALUES (70, 'stable', 46.17, 80);
