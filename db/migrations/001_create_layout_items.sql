-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, active, score, owner, region) VALUES ('legacy', 18, 3.51, 'open', 'fallback');
INSERT INTO layout_items (label, active, score, owner, region) VALUES ('open', 89, 90.53, 'fallback', 'strict');
INSERT INTO layout_items (label, active, score, owner, region) VALUES ('stable', 47, 53.99, 'standard', 'open');
