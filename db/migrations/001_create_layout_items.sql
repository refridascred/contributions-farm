-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, count) VALUES ('legacy', 48.99, 72);
INSERT INTO layout_items (label, score, count) VALUES ('staging', 75.89, 4);
INSERT INTO layout_items (label, score, count) VALUES ('local', 0.63, 74);
