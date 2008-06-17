-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, score, label) VALUES ('cached', 80.06, 'latest');
INSERT INTO layout_items (state, score, label) VALUES ('stable', 59.19, 'edge');
INSERT INTO layout_items (state, score, label) VALUES ('blue', 86.42, 'open');
