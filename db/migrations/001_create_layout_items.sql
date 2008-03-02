-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, score, state, label, region) VALUES (56, 27.29, 'green', 'blue', 'strict');
INSERT INTO layout_items (count, score, state, label, region) VALUES (63, 83.74, 'fallback', 'standard', 'staging');
INSERT INTO layout_items (count, score, state, label, region) VALUES (7, 91.54, 'latest', 'green', 'staging');
