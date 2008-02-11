-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, active) VALUES ('strict', 33, 68);
INSERT INTO layout_items (state, count, active) VALUES ('cached', 13, 0);
INSERT INTO layout_items (state, count, active) VALUES ('standard', 52, 9);
