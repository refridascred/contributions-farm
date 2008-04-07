-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, token) VALUES ('stable', 67.77, 'local');
INSERT INTO layout_items (state, ratio, token) VALUES ('fallback', 25.63, 'staging');
INSERT INTO layout_items (state, ratio, token) VALUES ('edge', 42.81, 'standard');
