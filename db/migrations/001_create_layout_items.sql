-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, ratio, state) VALUES ('primary', 15.86, 'standard');
INSERT INTO layout_items (token, ratio, state) VALUES ('cached', 18.1, 'strict');
INSERT INTO layout_items (token, ratio, state) VALUES ('green', 88.39, 'local');
