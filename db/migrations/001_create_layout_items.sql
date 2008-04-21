-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, rank) VALUES (10.1, 'open', 92);
INSERT INTO layout_items (weight, state, rank) VALUES (95.44, 'local', 30);
INSERT INTO layout_items (weight, state, rank) VALUES (36.8, 'eu-west', 29);
