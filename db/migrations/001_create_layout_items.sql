-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, label, score) VALUES ('primary', 'fallback', 66.66);
INSERT INTO layout_items (token, label, score) VALUES ('eu-west', 'staging', 87.35);
INSERT INTO layout_items (token, label, score) VALUES ('standard', 'local', 22.52);
