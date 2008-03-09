-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, state, token) VALUES (87.39, 'primary', 'blue');
INSERT INTO layout_items (ratio, state, token) VALUES (47.43, 'blue', 'eu-west');
INSERT INTO layout_items (ratio, state, token) VALUES (45.91, 'staging', 'blue');
