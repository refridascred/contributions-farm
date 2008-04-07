-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, active, token, score, owner) VALUES ('cached', 51, 'edge', 46.05, 'latest');
INSERT INTO layout_items (label, active, token, score, owner) VALUES ('latest', 71, 'fallback', 47.95, 'staging');
