-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, state, ratio, rank) VALUES (26.17, 'eu-west', 23.25, 73);
INSERT INTO layout_items (weight, state, ratio, rank) VALUES (19.11, 'legacy', 49.53, 75);
INSERT INTO layout_items (weight, state, ratio, rank) VALUES (11.41, 'primary', 22.77, 23);
