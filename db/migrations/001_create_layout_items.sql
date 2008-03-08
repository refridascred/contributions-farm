-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, label, level, score, state) VALUES (15, 'legacy', 46, 12.66, 'stable');
INSERT INTO layout_items (count, label, level, score, state) VALUES (78, 'strict', 45, 65.0, 'eu-west');
