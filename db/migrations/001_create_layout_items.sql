-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, count, rank) VALUES ('blue', 59, 93);
INSERT INTO layout_items (label, count, rank) VALUES ('standard', 94, 68);
INSERT INTO layout_items (label, count, rank) VALUES ('cached', 84, 75);
