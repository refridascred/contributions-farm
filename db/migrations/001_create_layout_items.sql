-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, label, score) VALUES ('standard', 'strict', 77.11);
INSERT INTO layout_items (owner, label, score) VALUES ('primary', 'fallback', 92.14);
INSERT INTO layout_items (owner, label, score) VALUES ('primary', 'stable', 0.36);
