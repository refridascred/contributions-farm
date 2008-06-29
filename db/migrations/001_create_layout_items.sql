-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, ratio, state, owner) VALUES (61.44, 'fallback', 84.12, 'eu-west', 'edge');
INSERT INTO layout_items (score, label, ratio, state, owner) VALUES (80.55, 'staging', 72.57, 'legacy', 'cached');
