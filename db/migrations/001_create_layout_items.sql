-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, state, weight, count, label) VALUES (52, 'edge', 96.88, 59, 'stable');
INSERT INTO layout_items (rank, state, weight, count, label) VALUES (60, 'cached', 31.16, 70, 'eu-west');
INSERT INTO layout_items (rank, state, weight, count, label) VALUES (90, 'primary', 67.22, 82, 'edge');
