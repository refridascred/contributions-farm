-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, active, state) VALUES (84.46, 72, 'legacy');
INSERT INTO layout_items (weight, active, state) VALUES (5.93, 47, 'staging');
INSERT INTO layout_items (weight, active, state) VALUES (0.73, 66, 'green');
