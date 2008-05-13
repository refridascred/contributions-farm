-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, level, active, owner, label) VALUES (90.29, 13, 40, 'green', 'legacy');
INSERT INTO layout_items (score, level, active, owner, label) VALUES (21.1, 0, 55, 'cached', 'open');
INSERT INTO layout_items (score, level, active, owner, label) VALUES (5.42, 8, 26, 'fallback', 'green');
