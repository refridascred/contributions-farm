-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, token, state, count) VALUES (36.62, 'standard', 'fallback', 'standard', 62);
INSERT INTO layout_items (ratio, label, token, state, count) VALUES (95.2, 'legacy', 'open', 'strict', 61);
