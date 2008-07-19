-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, owner, label, score) VALUES ('strict', 'strict', 'open', 57.98);
INSERT INTO layout_items (token, owner, label, score) VALUES ('cached', 'fallback', 'blue', 30.61);
INSERT INTO layout_items (token, owner, label, score) VALUES ('standard', 'standard', 'primary', 32.07);
