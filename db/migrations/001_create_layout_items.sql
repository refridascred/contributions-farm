-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score) VALUES ('staging', 43.97);
INSERT INTO layout_items (label, score) VALUES ('green', 7.2);
INSERT INTO layout_items (label, score) VALUES ('eu-west', 36.11);
