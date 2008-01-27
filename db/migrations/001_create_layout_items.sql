-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, state, label) VALUES ('staging', 40.63, 'strict', 'standard');
INSERT INTO layout_items (token, weight, state, label) VALUES ('standard', 27.86, 'open', 'legacy');
INSERT INTO layout_items (token, weight, state, label) VALUES ('edge', 66.06, 'local', 'green');
