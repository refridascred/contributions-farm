-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, weight, count, token) VALUES ('latest', 30.18, 46, 'fallback');
INSERT INTO layout_items (state, weight, count, token) VALUES ('primary', 20.01, 57, 'staging');
INSERT INTO layout_items (state, weight, count, token) VALUES ('eu-west', 74.8, 26, 'open');
