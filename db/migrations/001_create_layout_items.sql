-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, count, token) VALUES (38.27, 'standard', 28, 'edge');
INSERT INTO layout_items (ratio, state, count, token) VALUES (98.41, 'primary', 57, 'eu-west');
INSERT INTO layout_items (ratio, state, count, token) VALUES (44.34, 'latest', 28, 'open');
