-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, score, state, region) VALUES (52.46, 'open', 68.96, 'edge', 'blue');
INSERT INTO layout_items (ratio, label, score, state, region) VALUES (45.8, 'eu-west', 45.65, 'cached', 'cached');
INSERT INTO layout_items (ratio, label, score, state, region) VALUES (47.92, 'edge', 82.56, 'strict', 'eu-west');
