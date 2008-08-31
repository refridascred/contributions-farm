-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, active, weight) VALUES ('staging', 57, 11.72);
INSERT INTO layout_items (state, active, weight) VALUES ('primary', 66, 32.31);
INSERT INTO layout_items (state, active, weight) VALUES ('green', 55, 74.83);
