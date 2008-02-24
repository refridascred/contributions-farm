-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, region, state) VALUES (93.81, 'stable', 'local', 'legacy');
INSERT INTO layout_items (score, label, region, state) VALUES (78.41, 'cached', 'strict', 'eu-west');
INSERT INTO layout_items (score, label, region, state) VALUES (71.5, 'local', 'fallback', 'open');
