-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, score, label, owner) VALUES (6.58, 'edge', 79.92, 'open', 'cached');
INSERT INTO layout_items (ratio, token, score, label, owner) VALUES (18.28, 'cached', 81.83, 'blue', 'standard');
