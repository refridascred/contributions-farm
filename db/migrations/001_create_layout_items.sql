-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, label, state, ratio, token) VALUES (62.88, 'strict', 'staging', 43.44, 'blue');
INSERT INTO layout_items (score, label, state, ratio, token) VALUES (66.17, 'green', 'green', 23.91, 'legacy');
INSERT INTO layout_items (score, label, state, ratio, token) VALUES (10.67, 'local', 'local', 38.2, 'fallback');
