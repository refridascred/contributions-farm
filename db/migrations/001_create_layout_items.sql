-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, rank, label, level) VALUES (34.5, 41, 'fallback', 15);
INSERT INTO layout_items (score, rank, label, level) VALUES (16.48, 49, 'standard', 56);
