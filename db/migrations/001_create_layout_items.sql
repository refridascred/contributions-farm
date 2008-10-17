-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, owner, count, state, score) VALUES ('fallback', 'fallback', 48, 'latest', 61.07);
INSERT INTO layout_items (label, owner, count, state, score) VALUES ('primary', 'edge', 49, 'staging', 77.26);
INSERT INTO layout_items (label, owner, count, state, score) VALUES ('standard', 'legacy', 82, 'standard', 30.49);
