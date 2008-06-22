-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, count, rank) VALUES ('local', 79, 70);
INSERT INTO layout_items (state, count, rank) VALUES ('fallback', 40, 79);
INSERT INTO layout_items (state, count, rank) VALUES ('open', 57, 51);
