-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, active, rank, score) VALUES ('strict', 2, 66, 45.3);
INSERT INTO layout_items (label, active, rank, score) VALUES ('standard', 24, 83, 49.75);
INSERT INTO layout_items (label, active, rank, score) VALUES ('staging', 61, 49, 47.26);
