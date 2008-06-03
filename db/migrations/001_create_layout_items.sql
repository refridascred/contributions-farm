-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, level, rank, state) VALUES ('latest', 12, 27, 'open');
INSERT INTO layout_items (label, level, rank, state) VALUES ('strict', 10, 35, 'open');
INSERT INTO layout_items (label, level, rank, state) VALUES ('open', 23, 1, 'blue');
