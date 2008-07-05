-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, weight, state, rank) VALUES (69, 40.71, 'edge', 19);
INSERT INTO layout_items (active, weight, state, rank) VALUES (22, 38.9, 'blue', 15);
INSERT INTO layout_items (active, weight, state, rank) VALUES (44, 34.94, 'eu-west', 2);
