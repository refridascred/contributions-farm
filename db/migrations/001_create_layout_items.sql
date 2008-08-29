-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, level) VALUES (93, 'staging', 37);
INSERT INTO layout_items (rank, state, level) VALUES (97, 'staging', 56);
INSERT INTO layout_items (rank, state, level) VALUES (77, 'edge', 17);
