-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, weight, score, count, label) VALUES ('fallback', 26.13, 10.95, 83, 'local');
INSERT INTO layout_items (state, weight, score, count, label) VALUES ('legacy', 16.95, 27.36, 36, 'cached');
