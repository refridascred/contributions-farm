-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, active, label, count, rank) VALUES ('cached', 73, 'staging', 57, 59);
INSERT INTO layout_items (token, active, label, count, rank) VALUES ('standard', 5, 'latest', 69, 51);
INSERT INTO layout_items (token, active, label, count, rank) VALUES ('primary', 15, 'legacy', 43, 59);
