-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, label, score, state, count) VALUES (82.02, 'cached', 69.45, 'local', 18);
INSERT INTO layout_items (ratio, label, score, state, count) VALUES (75.12, 'eu-west', 95.97, 'fallback', 79);
INSERT INTO layout_items (ratio, label, score, state, count) VALUES (73.67, 'stable', 30.75, 'fallback', 74);
