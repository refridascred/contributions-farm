-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, active, count, label) VALUES (44, 83, 81, 'primary');
INSERT INTO layout_items (rank, active, count, label) VALUES (42, 19, 7, 'fallback');
INSERT INTO layout_items (rank, active, count, label) VALUES (90, 4, 21, 'fallback');
