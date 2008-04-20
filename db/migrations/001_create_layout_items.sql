-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, label, token, state) VALUES (75.25, 'latest', 'primary', 'blue');
INSERT INTO layout_items (weight, label, token, state) VALUES (9.26, 'local', 'latest', 'blue');
