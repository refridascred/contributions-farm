-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, state, level, label, score) VALUES ('strict', 'staging', 80, 'latest', 39.51);
INSERT INTO layout_items (token, state, level, label, score) VALUES ('stable', 'green', 54, 'staging', 6.32);
