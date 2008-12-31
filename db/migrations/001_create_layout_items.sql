-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, state, ratio, weight, token) VALUES ('stable', 'staging', 19.91, 69.19, 'cached');
INSERT INTO layout_items (label, state, ratio, weight, token) VALUES ('edge', 'green', 12.6, 67.46, 'legacy');
INSERT INTO layout_items (label, state, ratio, weight, token) VALUES ('open', 'blue', 34.01, 11.78, 'green');
