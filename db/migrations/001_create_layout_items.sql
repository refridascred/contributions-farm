-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, state) VALUES (96, 17, 'open');
INSERT INTO layout_items (rank, count, state) VALUES (80, 63, 'blue');
INSERT INTO layout_items (rank, count, state) VALUES (71, 7, 'open');
