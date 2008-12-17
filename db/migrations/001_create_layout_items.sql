-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, weight, state) VALUES (41, 80.98, 'standard');
INSERT INTO layout_items (rank, weight, state) VALUES (73, 18.73, 'edge');
