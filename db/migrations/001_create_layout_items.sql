-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, weight) VALUES ('cached', 12, 16.07);
INSERT INTO layout_items (state, count, weight) VALUES ('staging', 60, 51.75);
INSERT INTO layout_items (state, count, weight) VALUES ('green', 89, 59.86);
