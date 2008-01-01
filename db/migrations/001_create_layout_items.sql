-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, label, active, count, score) VALUES ('open', 'eu-west', 92, 98, 86.43);
INSERT INTO layout_items (state, label, active, count, score) VALUES ('fallback', 'local', 21, 5, 26.48);
INSERT INTO layout_items (state, label, active, count, score) VALUES ('stable', 'strict', 6, 36, 57.41);
