-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, weight, token) VALUES (28.26, 'blue', 75.35, 'green');
INSERT INTO layout_items (ratio, state, weight, token) VALUES (7.51, 'blue', 12.79, 'strict');
INSERT INTO layout_items (ratio, state, weight, token) VALUES (33.54, 'eu-west', 6.28, 'primary');
