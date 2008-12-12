-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, score) VALUES (9.72, 'primary', 39.53);
INSERT INTO layout_items (weight, state, score) VALUES (68.1, 'standard', 77.86);
INSERT INTO layout_items (weight, state, score) VALUES (87.87, 'local', 5.35);
